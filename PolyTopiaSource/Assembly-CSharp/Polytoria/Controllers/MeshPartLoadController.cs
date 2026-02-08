using System;
using GLTFast;
using GLTFast.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000332 RID: 818
	public class MeshPartLoadController : MonoBehaviour
	{
		// Token: 0x06004611 RID: 17937 RVA: 0x00138674 File Offset: 0x00136874
		// Note: this type is marked as 'beforefieldinit'.
		static MeshPartLoadController()
		{
			Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "MeshPartLoadController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr);
			MeshPartLoadController.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "Instance");
			MeshPartLoadController.NativeFieldInfoPtr_loadQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "loadQueue");
			MeshPartLoadController.NativeFieldInfoPtr_meshStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "meshStorage");
			MeshPartLoadController.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "loading");
			MeshPartLoadController.NativeFieldInfoPtr_importSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "importSettings");
			MeshPartLoadController.NativeFieldInfoPtr_instantiationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "instantiationSettings");
			MeshPartLoadController.NativeFieldInfoPtr__Importer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "<Importer>k__BackingField");
			MeshPartLoadController.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "logger");
			MeshPartLoadController.NativeMethodInfoPtr_get_Importer_Public_get_GltfImport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674383);
			MeshPartLoadController.NativeMethodInfoPtr_set_Importer_Protected_set_Void_GltfImport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674384);
			MeshPartLoadController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674399);
			MeshPartLoadController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674385);
			MeshPartLoadController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674386);
			MeshPartLoadController.NativeMethodInfoPtr_LoadMesh_Public_Void_MeshPartLoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674387);
			MeshPartLoadController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674388);
			MeshPartLoadController.NativeMethodInfoPtr_LoadMeshAsync_Private_Task_MeshPartLoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674389);
			MeshPartLoadController.NativeMethodInfoPtr_FindInCache_Private_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674390);
			MeshPartLoadController.NativeMethodInfoPtr_GetMeshUrlAsync_Private_Task_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674391);
			MeshPartLoadController.NativeMethodInfoPtr_ImportMeshAsync_Private_Task_1_GameObject_MeshPartLoadRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674392);
			MeshPartLoadController.NativeMethodInfoPtr_CacheLoadedObject_Private_Void_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674393);
			MeshPartLoadController.NativeMethodInfoPtr_ProcessLoadedObject_Private_Void_MeshPartLoadRequest_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674394);
			MeshPartLoadController.NativeMethodInfoPtr_ClearExistingChildren_Private_Void_MeshPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674395);
			MeshPartLoadController.NativeMethodInfoPtr_AdjustLoadedObjectBounds_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674396);
			MeshPartLoadController.NativeMethodInfoPtr_AttachLoadedObjectToMeshPart_Private_Void_MeshPartLoadRequest_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674397);
			MeshPartLoadController.NativeMethodInfoPtr_EnableRenderers_Private_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, 100674398);
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x00138898 File Offset: 0x00136A98
		// (set) Token: 0x06004613 RID: 17939 RVA: 0x001388D8 File Offset: 0x00136AD8
		public unsafe GltfImport Importer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_get_Importer_Public_get_GltfImport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GltfImport>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_set_Importer_Protected_set_Void_GltfImport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x0013891C File Offset: 0x00136B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135625, XrefRangeEnd = 135633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshPartLoadController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00138958 File Offset: 0x00136B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135633, XrefRangeEnd = 135637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x0013898C File Offset: 0x00136B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135637, XrefRangeEnd = 135647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x001389C0 File Offset: 0x00136BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135650, RefRangeEnd = 135652, XrefRangeStart = 135647, XrefRangeEnd = 135650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadMesh(MeshPartLoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_LoadMesh_Public_Void_MeshPartLoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x00138A04 File Offset: 0x00136C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135652, XrefRangeEnd = 135667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00138A38 File Offset: 0x00136C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135667, XrefRangeEnd = 135678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task LoadMeshAsync(MeshPartLoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_LoadMeshAsync_Private_Task_MeshPartLoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x00138A88 File Offset: 0x00136C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135678, XrefRangeEnd = 135686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject FindInCache(int assetID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assetID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_FindInCache_Private_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00138AD4 File Offset: 0x00136CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135686, XrefRangeEnd = 135699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> GetMeshUrlAsync(int assetID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assetID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_GetMeshUrlAsync_Private_Task_1_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00138B20 File Offset: 0x00136D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135699, XrefRangeEnd = 135715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<GameObject> ImportMeshAsync(MeshPartLoadRequest request, string meshUrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(meshUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_ImportMeshAsync_Private_Task_1_GameObject_MeshPartLoadRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GameObject>>(intPtr3) : null;
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00138B84 File Offset: 0x00136D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135715, XrefRangeEnd = 135733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheLoadedObject(int assetID, GameObject loadedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assetID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_CacheLoadedObject_Private_Void_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x00138BD4 File Offset: 0x00136DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135733, XrefRangeEnd = 135749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessLoadedObject(MeshPartLoadRequest request, GameObject loadedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_ProcessLoadedObject_Private_Void_MeshPartLoadRequest_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x00138C28 File Offset: 0x00136E28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135779, RefRangeEnd = 135781, XrefRangeStart = 135749, XrefRangeEnd = 135779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearExistingChildren(MeshPart meshPart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshPart);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_ClearExistingChildren_Private_Void_MeshPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00138C6C File Offset: 0x00136E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135816, RefRangeEnd = 135818, XrefRangeStart = 135781, XrefRangeEnd = 135816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustLoadedObjectBounds(GameObject loadedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_AdjustLoadedObjectBounds_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00138CB0 File Offset: 0x00136EB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135856, RefRangeEnd = 135858, XrefRangeStart = 135818, XrefRangeEnd = 135856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachLoadedObjectToMeshPart(MeshPartLoadRequest request, GameObject loadedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_AttachLoadedObjectToMeshPart_Private_Void_MeshPartLoadRequest_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x00138D04 File Offset: 0x00136F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135863, RefRangeEnd = 135865, XrefRangeStart = 135858, XrefRangeEnd = 135863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableRenderers(GameObject obj, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController.NativeMethodInfoPtr_EnableRenderers_Private_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x00019E99 File Offset: 0x00018099
		public MeshPartLoadController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x00138D54 File Offset: 0x00136F54
		// (set) Token: 0x06004625 RID: 17957 RVA: 0x00019EA2 File Offset: 0x000180A2
		public unsafe static MeshPartLoadController Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MeshPartLoadController.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshPartLoadController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshPartLoadController.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x00138D7C File Offset: 0x00136F7C
		// (set) Token: 0x06004627 RID: 17959 RVA: 0x00019EB4 File Offset: 0x000180B4
		public unsafe Queue<MeshPartLoadRequest> loadQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_loadQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<MeshPartLoadRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_loadQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06004628 RID: 17960 RVA: 0x00138DAC File Offset: 0x00136FAC
		// (set) Token: 0x06004629 RID: 17961 RVA: 0x00019ED3 File Offset: 0x000180D3
		public unsafe GameObject meshStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_meshStorage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_meshStorage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x0600462A RID: 17962 RVA: 0x00138DDC File Offset: 0x00136FDC
		// (set) Token: 0x0600462B RID: 17963 RVA: 0x00019EF2 File Offset: 0x000180F2
		public unsafe bool loading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_loading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_loading)) = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x00138E04 File Offset: 0x00137004
		// (set) Token: 0x0600462D RID: 17965 RVA: 0x00019F0D File Offset: 0x0001810D
		public unsafe ImportSettings importSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_importSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImportSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_importSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x0600462E RID: 17966 RVA: 0x00138E34 File Offset: 0x00137034
		// (set) Token: 0x0600462F RID: 17967 RVA: 0x00019F2C File Offset: 0x0001812C
		public unsafe InstantiationSettings instantiationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_instantiationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InstantiationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_instantiationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x00138E64 File Offset: 0x00137064
		// (set) Token: 0x06004631 RID: 17969 RVA: 0x00019F4B File Offset: 0x0001814B
		public unsafe GltfImport _Importer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr__Importer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GltfImport>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr__Importer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x00138E94 File Offset: 0x00137094
		// (set) Token: 0x06004633 RID: 17971 RVA: 0x00019F6A File Offset: 0x0001816A
		public unsafe ConsoleLogger logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsoleLogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController.NativeFieldInfoPtr_logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003661 RID: 13921
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04003662 RID: 13922
		private static readonly IntPtr NativeFieldInfoPtr_loadQueue;

		// Token: 0x04003663 RID: 13923
		private static readonly IntPtr NativeFieldInfoPtr_meshStorage;

		// Token: 0x04003664 RID: 13924
		private static readonly IntPtr NativeFieldInfoPtr_loading;

		// Token: 0x04003665 RID: 13925
		private static readonly IntPtr NativeFieldInfoPtr_importSettings;

		// Token: 0x04003666 RID: 13926
		private static readonly IntPtr NativeFieldInfoPtr_instantiationSettings;

		// Token: 0x04003667 RID: 13927
		private static readonly IntPtr NativeFieldInfoPtr__Importer_k__BackingField;

		// Token: 0x04003668 RID: 13928
		private static readonly IntPtr NativeFieldInfoPtr_logger;

		// Token: 0x04003669 RID: 13929
		private static readonly IntPtr NativeMethodInfoPtr_get_Importer_Public_get_GltfImport_0;

		// Token: 0x0400366A RID: 13930
		private static readonly IntPtr NativeMethodInfoPtr_set_Importer_Protected_set_Void_GltfImport_0;

		// Token: 0x0400366B RID: 13931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400366C RID: 13932
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400366D RID: 13933
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400366E RID: 13934
		private static readonly IntPtr NativeMethodInfoPtr_LoadMesh_Public_Void_MeshPartLoadRequest_0;

		// Token: 0x0400366F RID: 13935
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003670 RID: 13936
		private static readonly IntPtr NativeMethodInfoPtr_LoadMeshAsync_Private_Task_MeshPartLoadRequest_0;

		// Token: 0x04003671 RID: 13937
		private static readonly IntPtr NativeMethodInfoPtr_FindInCache_Private_GameObject_Int32_0;

		// Token: 0x04003672 RID: 13938
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshUrlAsync_Private_Task_1_String_Int32_0;

		// Token: 0x04003673 RID: 13939
		private static readonly IntPtr NativeMethodInfoPtr_ImportMeshAsync_Private_Task_1_GameObject_MeshPartLoadRequest_String_0;

		// Token: 0x04003674 RID: 13940
		private static readonly IntPtr NativeMethodInfoPtr_CacheLoadedObject_Private_Void_Int32_GameObject_0;

		// Token: 0x04003675 RID: 13941
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLoadedObject_Private_Void_MeshPartLoadRequest_GameObject_0;

		// Token: 0x04003676 RID: 13942
		private static readonly IntPtr NativeMethodInfoPtr_ClearExistingChildren_Private_Void_MeshPart_0;

		// Token: 0x04003677 RID: 13943
		private static readonly IntPtr NativeMethodInfoPtr_AdjustLoadedObjectBounds_Private_Void_GameObject_0;

		// Token: 0x04003678 RID: 13944
		private static readonly IntPtr NativeMethodInfoPtr_AttachLoadedObjectToMeshPart_Private_Void_MeshPartLoadRequest_GameObject_0;

		// Token: 0x04003679 RID: 13945
		private static readonly IntPtr NativeMethodInfoPtr_EnableRenderers_Private_Void_GameObject_Boolean_0;

		// Token: 0x02000430 RID: 1072
		[ObfuscatedName("Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17")]
		public sealed class _GetMeshUrlAsync_d__17 : ValueType
		{
			// Token: 0x0600522F RID: 21039 RVA: 0x0015E4F8 File Offset: 0x0015C6F8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetMeshUrlAsync_d__17()
			{
				Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "<GetMeshUrlAsync>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr);
				MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr, "<>1__state");
				MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr, "<>t__builder");
				MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr_assetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr, "assetID");
				MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr__client_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr, "<client>5__2");
				MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr, "<>u__1");
				MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr, "<>u__2");
				MeshPartLoadController._GetMeshUrlAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr, 100674400);
				MeshPartLoadController._GetMeshUrlAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr, 100674401);
			}

			// Token: 0x06005230 RID: 21040 RVA: 0x0015E5C4 File Offset: 0x0015C7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135336, XrefRangeEnd = 135444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005231 RID: 21041 RVA: 0x0015E5FC File Offset: 0x0015C7FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135444, XrefRangeEnd = 135450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005232 RID: 21042 RVA: 0x0001FB67 File Offset: 0x0001DD67
			public _GetMeshUrlAsync_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005233 RID: 21043 RVA: 0x0001FB70 File Offset: 0x0001DD70
			public _GetMeshUrlAsync_d__17()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPartLoadController._GetMeshUrlAsync_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x17001BBB RID: 7099
			// (get) Token: 0x06005234 RID: 21044 RVA: 0x0015E644 File Offset: 0x0015C844
			// (set) Token: 0x06005235 RID: 21045 RVA: 0x0001FB82 File Offset: 0x0001DD82
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BBC RID: 7100
			// (get) Token: 0x06005236 RID: 21046 RVA: 0x0015E66C File Offset: 0x0015C86C
			// (set) Token: 0x06005237 RID: 21047 RVA: 0x0001FB9D File Offset: 0x0001DD9D
			public unsafe AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___t__builder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncTaskMethodBuilder<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBD RID: 7101
			// (get) Token: 0x06005238 RID: 21048 RVA: 0x0015E69C File Offset: 0x0015C89C
			// (set) Token: 0x06005239 RID: 21049 RVA: 0x0001FBBC File Offset: 0x0001DDBC
			public unsafe int assetID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr_assetID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr_assetID)) = value;
				}
			}

			// Token: 0x17001BBE RID: 7102
			// (get) Token: 0x0600523A RID: 21050 RVA: 0x0015E6C4 File Offset: 0x0015C8C4
			// (set) Token: 0x0600523B RID: 21051 RVA: 0x0001FBD7 File Offset: 0x0001DDD7
			public unsafe HttpClient _client_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr__client_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr__client_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBF RID: 7103
			// (get) Token: 0x0600523C RID: 21052 RVA: 0x0015E6F4 File Offset: 0x0015C8F4
			// (set) Token: 0x0600523D RID: 21053 RVA: 0x0001FBF6 File Offset: 0x0001DDF6
			public unsafe TaskAwaiter<HttpResponseMessage> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___u__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskAwaiter<HttpResponseMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___u__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC0 RID: 7104
			// (get) Token: 0x0600523E RID: 21054 RVA: 0x0015E724 File Offset: 0x0015C924
			// (set) Token: 0x0600523F RID: 21055 RVA: 0x0001FC15 File Offset: 0x0001DE15
			public unsafe TaskAwaiter<string> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___u__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskAwaiter<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._GetMeshUrlAsync_d__17.NativeFieldInfoPtr___u__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EFC RID: 16124
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003EFD RID: 16125
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04003EFE RID: 16126
			private static readonly IntPtr NativeFieldInfoPtr_assetID;

			// Token: 0x04003EFF RID: 16127
			private static readonly IntPtr NativeFieldInfoPtr__client_5__2;

			// Token: 0x04003F00 RID: 16128
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04003F01 RID: 16129
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04003F02 RID: 16130
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F03 RID: 16131
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000431 RID: 1073
		[ObfuscatedName("Polytoria.Controllers.MeshPartLoadController+<ImportMeshAsync>d__18")]
		public sealed class _ImportMeshAsync_d__18 : ValueType
		{
			// Token: 0x06005240 RID: 21056 RVA: 0x0015E754 File Offset: 0x0015C954
			// Note: this type is marked as 'beforefieldinit'.
			static _ImportMeshAsync_d__18()
			{
				Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "<ImportMeshAsync>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr);
				MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, "<>1__state");
				MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, "<>t__builder");
				MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, "<>4__this");
				MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr_meshUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, "meshUrl");
				MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, "request");
				MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, "<>u__1");
				MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr__loadedObject_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, "<loadedObject>5__2");
				MeshPartLoadController._ImportMeshAsync_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, 100674402);
				MeshPartLoadController._ImportMeshAsync_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr, 100674403);
			}

			// Token: 0x06005241 RID: 21057 RVA: 0x0015E834 File Offset: 0x0015CA34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135450, XrefRangeEnd = 135493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController._ImportMeshAsync_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005242 RID: 21058 RVA: 0x0015E86C File Offset: 0x0015CA6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135493, XrefRangeEnd = 135499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController._ImportMeshAsync_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005243 RID: 21059 RVA: 0x0001FC34 File Offset: 0x0001DE34
			public _ImportMeshAsync_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005244 RID: 21060 RVA: 0x0001FC3D File Offset: 0x0001DE3D
			public _ImportMeshAsync_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPartLoadController._ImportMeshAsync_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x17001BC1 RID: 7105
			// (get) Token: 0x06005245 RID: 21061 RVA: 0x0015E8B4 File Offset: 0x0015CAB4
			// (set) Token: 0x06005246 RID: 21062 RVA: 0x0001FC4F File Offset: 0x0001DE4F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BC2 RID: 7106
			// (get) Token: 0x06005247 RID: 21063 RVA: 0x0015E8DC File Offset: 0x0015CADC
			// (set) Token: 0x06005248 RID: 21064 RVA: 0x0001FC6A File Offset: 0x0001DE6A
			public unsafe AsyncTaskMethodBuilder<GameObject> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___t__builder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncTaskMethodBuilder<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC3 RID: 7107
			// (get) Token: 0x06005249 RID: 21065 RVA: 0x0015E90C File Offset: 0x0015CB0C
			// (set) Token: 0x0600524A RID: 21066 RVA: 0x0001FC89 File Offset: 0x0001DE89
			public unsafe MeshPartLoadController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshPartLoadController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC4 RID: 7108
			// (get) Token: 0x0600524B RID: 21067 RVA: 0x0015E93C File Offset: 0x0015CB3C
			// (set) Token: 0x0600524C RID: 21068 RVA: 0x0001FCA8 File Offset: 0x0001DEA8
			public unsafe string meshUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr_meshUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr_meshUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001BC5 RID: 7109
			// (get) Token: 0x0600524D RID: 21069 RVA: 0x0015E964 File Offset: 0x0015CB64
			// (set) Token: 0x0600524E RID: 21070 RVA: 0x0001FCC7 File Offset: 0x0001DEC7
			public unsafe MeshPartLoadRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshPartLoadRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC6 RID: 7110
			// (get) Token: 0x0600524F RID: 21071 RVA: 0x0015E994 File Offset: 0x0015CB94
			// (set) Token: 0x06005250 RID: 21072 RVA: 0x0001FCE6 File Offset: 0x0001DEE6
			public unsafe TaskAwaiter<bool> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___u__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskAwaiter<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr___u__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC7 RID: 7111
			// (get) Token: 0x06005251 RID: 21073 RVA: 0x0015E9C4 File Offset: 0x0015CBC4
			// (set) Token: 0x06005252 RID: 21074 RVA: 0x0001FD05 File Offset: 0x0001DF05
			public unsafe GameObject _loadedObject_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr__loadedObject_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._ImportMeshAsync_d__18.NativeFieldInfoPtr__loadedObject_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F04 RID: 16132
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F05 RID: 16133
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04003F06 RID: 16134
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F07 RID: 16135
			private static readonly IntPtr NativeFieldInfoPtr_meshUrl;

			// Token: 0x04003F08 RID: 16136
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04003F09 RID: 16137
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04003F0A RID: 16138
			private static readonly IntPtr NativeFieldInfoPtr__loadedObject_5__2;

			// Token: 0x04003F0B RID: 16139
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F0C RID: 16140
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000432 RID: 1074
		[ObfuscatedName("Polytoria.Controllers.MeshPartLoadController+<LoadMeshAsync>d__15")]
		public sealed class _LoadMeshAsync_d__15 : ValueType
		{
			// Token: 0x06005253 RID: 21075 RVA: 0x0015E9F4 File Offset: 0x0015CBF4
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadMeshAsync_d__15()
			{
				Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPartLoadController>.NativeClassPtr, "<LoadMeshAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr);
				MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, "<>1__state");
				MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, "<>t__builder");
				MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, "<>4__this");
				MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, "request");
				MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr__loadedObject_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, "<loadedObject>5__2");
				MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, "<>u__1");
				MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, "<>u__2");
				MeshPartLoadController._LoadMeshAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, 100674404);
				MeshPartLoadController._LoadMeshAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr, 100674405);
			}

			// Token: 0x06005254 RID: 21076 RVA: 0x0015EAD4 File Offset: 0x0015CCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135499, XrefRangeEnd = 135621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController._LoadMeshAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005255 RID: 21077 RVA: 0x0015EB0C File Offset: 0x0015CD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135621, XrefRangeEnd = 135625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadController._LoadMeshAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005256 RID: 21078 RVA: 0x0001FD24 File Offset: 0x0001DF24
			public _LoadMeshAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005257 RID: 21079 RVA: 0x0001FD2D File Offset: 0x0001DF2D
			public _LoadMeshAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPartLoadController._LoadMeshAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x17001BC8 RID: 7112
			// (get) Token: 0x06005258 RID: 21080 RVA: 0x0015EB54 File Offset: 0x0015CD54
			// (set) Token: 0x06005259 RID: 21081 RVA: 0x0001FD3F File Offset: 0x0001DF3F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BC9 RID: 7113
			// (get) Token: 0x0600525A RID: 21082 RVA: 0x0015EB7C File Offset: 0x0015CD7C
			// (set) Token: 0x0600525B RID: 21083 RVA: 0x0001FD5A File Offset: 0x0001DF5A
			public unsafe AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___t__builder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncTaskMethodBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCA RID: 7114
			// (get) Token: 0x0600525C RID: 21084 RVA: 0x0015EBAC File Offset: 0x0015CDAC
			// (set) Token: 0x0600525D RID: 21085 RVA: 0x0001FD79 File Offset: 0x0001DF79
			public unsafe MeshPartLoadController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshPartLoadController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCB RID: 7115
			// (get) Token: 0x0600525E RID: 21086 RVA: 0x0015EBDC File Offset: 0x0015CDDC
			// (set) Token: 0x0600525F RID: 21087 RVA: 0x0001FD98 File Offset: 0x0001DF98
			public unsafe MeshPartLoadRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshPartLoadRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCC RID: 7116
			// (get) Token: 0x06005260 RID: 21088 RVA: 0x0015EC0C File Offset: 0x0015CE0C
			// (set) Token: 0x06005261 RID: 21089 RVA: 0x0001FDB7 File Offset: 0x0001DFB7
			public unsafe GameObject _loadedObject_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr__loadedObject_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr__loadedObject_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCD RID: 7117
			// (get) Token: 0x06005262 RID: 21090 RVA: 0x0015EC3C File Offset: 0x0015CE3C
			// (set) Token: 0x06005263 RID: 21091 RVA: 0x0001FDD6 File Offset: 0x0001DFD6
			public unsafe TaskAwaiter<string> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___u__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskAwaiter<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCE RID: 7118
			// (get) Token: 0x06005264 RID: 21092 RVA: 0x0015EC6C File Offset: 0x0015CE6C
			// (set) Token: 0x06005265 RID: 21093 RVA: 0x0001FDF5 File Offset: 0x0001DFF5
			public unsafe TaskAwaiter<GameObject> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___u__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskAwaiter<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadController._LoadMeshAsync_d__15.NativeFieldInfoPtr___u__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F0D RID: 16141
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F0E RID: 16142
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04003F0F RID: 16143
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F10 RID: 16144
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04003F11 RID: 16145
			private static readonly IntPtr NativeFieldInfoPtr__loadedObject_5__2;

			// Token: 0x04003F12 RID: 16146
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04003F13 RID: 16147
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04003F14 RID: 16148
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F15 RID: 16149
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
