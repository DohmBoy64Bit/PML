using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020001CD RID: 461
	[Serializable]
	public class ObjectGrabSettings : Settings
	{
		// Token: 0x060023B8 RID: 9144 RVA: 0x000AE5B4 File Offset: 0x000AC7B4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectGrabSettings()
		{
			Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectGrabSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr);
			ObjectGrabSettings.NativeFieldInfoPtr__alignAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_alignAxis");
			ObjectGrabSettings.NativeFieldInfoPtr__alignmentAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_alignmentAxis");
			ObjectGrabSettings.NativeFieldInfoPtr__rotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_rotationSensitivity");
			ObjectGrabSettings.NativeFieldInfoPtr__scaleSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_scaleSensitivity");
			ObjectGrabSettings.NativeFieldInfoPtr__offsetFromSurfaceSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_offsetFromSurfaceSensitivity");
			ObjectGrabSettings.NativeFieldInfoPtr__offsetFromAnchorSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_offsetFromAnchorSensitivity");
			ObjectGrabSettings.NativeFieldInfoPtr__surfaceFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_surfaceFlags");
			ObjectGrabSettings.NativeFieldInfoPtr__defaultOffsetFromSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_defaultOffsetFromSurface");
			ObjectGrabSettings.NativeFieldInfoPtr__surfaceLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_surfaceLayers");
			ObjectGrabSettings.NativeFieldInfoPtr__layerGrabSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_layerGrabSettings");
			ObjectGrabSettings.NativeFieldInfoPtr__sphericalMeshLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_sphericalMeshLayers");
			ObjectGrabSettings.NativeFieldInfoPtr__terrainMeshLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, "_terrainMeshLayers");
			ObjectGrabSettings.NativeMethodInfoPtr_get_AlignAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668656);
			ObjectGrabSettings.NativeMethodInfoPtr_set_AlignAxis_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668657);
			ObjectGrabSettings.NativeMethodInfoPtr_get_AlignmentAxis_Public_get_TransformAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668658);
			ObjectGrabSettings.NativeMethodInfoPtr_set_AlignmentAxis_Public_set_Void_TransformAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668659);
			ObjectGrabSettings.NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668660);
			ObjectGrabSettings.NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668661);
			ObjectGrabSettings.NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668662);
			ObjectGrabSettings.NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668663);
			ObjectGrabSettings.NativeMethodInfoPtr_get_OffsetFromSurfaceSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668664);
			ObjectGrabSettings.NativeMethodInfoPtr_set_OffsetFromSurfaceSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668665);
			ObjectGrabSettings.NativeMethodInfoPtr_get_OffsetFromAnchorSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668666);
			ObjectGrabSettings.NativeMethodInfoPtr_set_OffsetFromAnchorSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668667);
			ObjectGrabSettings.NativeMethodInfoPtr_get_SurfaceFlags_Public_get_ObjectGrabSurfaceFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668668);
			ObjectGrabSettings.NativeMethodInfoPtr_set_SurfaceFlags_Public_set_Void_ObjectGrabSurfaceFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668669);
			ObjectGrabSettings.NativeMethodInfoPtr_get_DefaultOffsetFromSurface_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668670);
			ObjectGrabSettings.NativeMethodInfoPtr_set_DefaultOffsetFromSurface_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668671);
			ObjectGrabSettings.NativeMethodInfoPtr_get_SurfaceLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668672);
			ObjectGrabSettings.NativeMethodInfoPtr_set_SurfaceLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668673);
			ObjectGrabSettings.NativeMethodInfoPtr_get_SphericalMeshLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668674);
			ObjectGrabSettings.NativeMethodInfoPtr_set_SphericalMeshLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668675);
			ObjectGrabSettings.NativeMethodInfoPtr_get_TerrainMeshLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668676);
			ObjectGrabSettings.NativeMethodInfoPtr_set_TerrainMeshLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668677);
			ObjectGrabSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668678);
			ObjectGrabSettings.NativeMethodInfoPtr_GetLayerGrabSettings_Public_ObjectLayerGrabSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr, 100668679);
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x000AE8B4 File Offset: 0x000ACAB4
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x000AE8F0 File Offset: 0x000ACAF0
		public unsafe bool AlignAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_AlignAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_AlignAxis_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x000AE930 File Offset: 0x000ACB30
		// (set) Token: 0x060023BC RID: 9148 RVA: 0x000AE970 File Offset: 0x000ACB70
		public unsafe TransformAxis AlignmentAxis
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28412, RefRangeEnd = 28413, XrefRangeStart = 28412, XrefRangeEnd = 28413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_AlignmentAxis_Public_get_TransformAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransformAxis>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28413, RefRangeEnd = 28414, XrefRangeStart = 28413, XrefRangeEnd = 28414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_AlignmentAxis_Public_set_Void_TransformAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000AE9B4 File Offset: 0x000ACBB4
		// (set) Token: 0x060023BE RID: 9150 RVA: 0x000AE9F0 File Offset: 0x000ACBF0
		public unsafe float RotationSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x000AEA30 File Offset: 0x000ACC30
		// (set) Token: 0x060023C0 RID: 9152 RVA: 0x000AEA6C File Offset: 0x000ACC6C
		public unsafe float ScaleSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x000AEAAC File Offset: 0x000ACCAC
		// (set) Token: 0x060023C2 RID: 9154 RVA: 0x000AEAE8 File Offset: 0x000ACCE8
		public unsafe float OffsetFromSurfaceSensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_OffsetFromSurfaceSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_OffsetFromSurfaceSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x000AEB28 File Offset: 0x000ACD28
		// (set) Token: 0x060023C4 RID: 9156 RVA: 0x000AEB64 File Offset: 0x000ACD64
		public unsafe float OffsetFromAnchorSensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_OffsetFromAnchorSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_OffsetFromAnchorSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x000AEBA4 File Offset: 0x000ACDA4
		// (set) Token: 0x060023C6 RID: 9158 RVA: 0x000AEBE4 File Offset: 0x000ACDE4
		public unsafe ObjectGrabSurfaceFlags SurfaceFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_SurfaceFlags_Public_get_ObjectGrabSurfaceFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGrabSurfaceFlags>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_SurfaceFlags_Public_set_Void_ObjectGrabSurfaceFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x000AEC28 File Offset: 0x000ACE28
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x000AEC64 File Offset: 0x000ACE64
		public unsafe float DefaultOffsetFromSurface
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_DefaultOffsetFromSurface_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_DefaultOffsetFromSurface_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x000AECA4 File Offset: 0x000ACEA4
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x000AECE0 File Offset: 0x000ACEE0
		public unsafe int SurfaceLayers
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 28415, RefRangeEnd = 28418, XrefRangeStart = 28415, XrefRangeEnd = 28418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_SurfaceLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_SurfaceLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x000AED20 File Offset: 0x000ACF20
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x000AED5C File Offset: 0x000ACF5C
		public unsafe int SphericalMeshLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_SphericalMeshLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_SphericalMeshLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x000AED9C File Offset: 0x000ACF9C
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x000AEDD8 File Offset: 0x000ACFD8
		public unsafe int TerrainMeshLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_get_TerrainMeshLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_set_TerrainMeshLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000AEE18 File Offset: 0x000AD018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88479, RefRangeEnd = 88480, XrefRangeStart = 88466, XrefRangeEnd = 88479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectGrabSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectGrabSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x000AEE54 File Offset: 0x000AD054
		[CallerCount(0)]
		public unsafe ObjectLayerGrabSettings GetLayerGrabSettings(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabSettings.NativeMethodInfoPtr_GetLayerGrabSettings_Public_ObjectLayerGrabSettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLayerGrabSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0000EA3C File Offset: 0x0000CC3C
		public ObjectGrabSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x000AEEA0 File Offset: 0x000AD0A0
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x0000EA45 File Offset: 0x0000CC45
		public unsafe bool _alignAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__alignAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__alignAxis)) = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000AEEC8 File Offset: 0x000AD0C8
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public unsafe TransformAxis _alignmentAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__alignmentAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransformAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__alignmentAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x000AEEF8 File Offset: 0x000AD0F8
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x0000EA7F File Offset: 0x0000CC7F
		public unsafe float _rotationSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__rotationSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__rotationSensitivity)) = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x000AEF20 File Offset: 0x000AD120
		// (set) Token: 0x060023D9 RID: 9177 RVA: 0x0000EA9A File Offset: 0x0000CC9A
		public unsafe float _scaleSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__scaleSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__scaleSensitivity)) = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x000AEF48 File Offset: 0x000AD148
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x0000EAB5 File Offset: 0x0000CCB5
		public unsafe float _offsetFromSurfaceSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__offsetFromSurfaceSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__offsetFromSurfaceSensitivity)) = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x000AEF70 File Offset: 0x000AD170
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		public unsafe float _offsetFromAnchorSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__offsetFromAnchorSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__offsetFromAnchorSensitivity)) = value;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x000AEF98 File Offset: 0x000AD198
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x0000EAEB File Offset: 0x0000CCEB
		public unsafe ObjectGrabSurfaceFlags _surfaceFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__surfaceFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabSurfaceFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__surfaceFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x000AEFC8 File Offset: 0x000AD1C8
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x0000EB0A File Offset: 0x0000CD0A
		public unsafe float _defaultOffsetFromSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__defaultOffsetFromSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__defaultOffsetFromSurface)) = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x0000EB25 File Offset: 0x0000CD25
		public unsafe int _surfaceLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__surfaceLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__surfaceLayers)) = value;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000AF018 File Offset: 0x000AD218
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x0000EB40 File Offset: 0x0000CD40
		public unsafe Il2CppReferenceArray<ObjectLayerGrabSettings> _layerGrabSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__layerGrabSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectLayerGrabSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__layerGrabSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000AF048 File Offset: 0x000AD248
		// (set) Token: 0x060023E7 RID: 9191 RVA: 0x0000EB5F File Offset: 0x0000CD5F
		public unsafe int _sphericalMeshLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__sphericalMeshLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__sphericalMeshLayers)) = value;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000AF070 File Offset: 0x000AD270
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x0000EB7A File Offset: 0x0000CD7A
		public unsafe int _terrainMeshLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__terrainMeshLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabSettings.NativeFieldInfoPtr__terrainMeshLayers)) = value;
			}
		}

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeFieldInfoPtr__alignAxis;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeFieldInfoPtr__alignmentAxis;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeFieldInfoPtr__rotationSensitivity;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeFieldInfoPtr__scaleSensitivity;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeFieldInfoPtr__offsetFromSurfaceSensitivity;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeFieldInfoPtr__offsetFromAnchorSensitivity;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr__surfaceFlags;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeFieldInfoPtr__defaultOffsetFromSurface;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeFieldInfoPtr__surfaceLayers;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeFieldInfoPtr__layerGrabSettings;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeFieldInfoPtr__sphericalMeshLayers;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeFieldInfoPtr__terrainMeshLayers;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_get_AlignAxis_Public_get_Boolean_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_set_AlignAxis_Public_set_Void_Boolean_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_get_AlignmentAxis_Public_get_TransformAxis_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_set_AlignmentAxis_Public_set_Void_TransformAxis_0;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetFromSurfaceSensitivity_Public_get_Single_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetFromSurfaceSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetFromAnchorSensitivity_Public_get_Single_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetFromAnchorSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_get_SurfaceFlags_Public_get_ObjectGrabSurfaceFlags_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_set_SurfaceFlags_Public_set_Void_ObjectGrabSurfaceFlags_0;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultOffsetFromSurface_Public_get_Single_0;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultOffsetFromSurface_Public_set_Void_Single_0;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr_get_SurfaceLayers_Public_get_Int32_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_set_SurfaceLayers_Public_set_Void_Int32_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_get_SphericalMeshLayers_Public_get_Int32_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_set_SphericalMeshLayers_Public_set_Void_Int32_0;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_get_TerrainMeshLayers_Public_get_Int32_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_set_TerrainMeshLayers_Public_set_Void_Int32_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerGrabSettings_Public_ObjectLayerGrabSettings_Int32_0;
	}
}
