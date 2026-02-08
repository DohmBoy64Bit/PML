using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class GizmoObjectVertexSnapSettings : Settings
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x00030324 File Offset: 0x0002E524
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoObjectVertexSnapSettings()
		{
			Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoObjectVertexSnapSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr);
			GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__snapDestinationLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, "_snapDestinationLayers");
			GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__canSnapToGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, "_canSnapToGrid");
			GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__canSnapToObjectVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, "_canSnapToObjectVerts");
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_get_SnapDestinationLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663869);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_set_SnapDestinationLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663870);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_get_CanSnapToGrid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663871);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_set_CanSnapToGrid_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663872);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_get_CanSnapToObjectVerts_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663873);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_set_CanSnapToObjectVerts_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663874);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663878);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_IsLayerSnapDestination_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663875);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_SetLayerSnapDestination_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663876);
			GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_Transfer_Public_Void_GizmoObjectVertexSnapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr, 100663877);
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00030458 File Offset: 0x0002E658
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00030494 File Offset: 0x0002E694
		public unsafe int SnapDestinationLayers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_get_SnapDestinationLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_set_SnapDestinationLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x000304D4 File Offset: 0x0002E6D4
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00030510 File Offset: 0x0002E710
		public unsafe bool CanSnapToGrid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_get_CanSnapToGrid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_set_CanSnapToGrid_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00030550 File Offset: 0x0002E750
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0003058C File Offset: 0x0002E78C
		public unsafe bool CanSnapToObjectVerts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_get_CanSnapToObjectVerts_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_set_CanSnapToObjectVerts_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000305CC File Offset: 0x0002E7CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59410, RefRangeEnd = 59412, XrefRangeStart = 59409, XrefRangeEnd = 59410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoObjectVertexSnapSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoObjectVertexSnapSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00030608 File Offset: 0x0002E808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59412, XrefRangeEnd = 59413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLayerSnapDestination(int objectLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_IsLayerSnapDestination_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00030654 File Offset: 0x0002E854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59413, XrefRangeEnd = 59414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerSnapDestination(int objectLayer, bool isSnapDestination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSnapDestination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_SetLayerSnapDestination_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000306A0 File Offset: 0x0002E8A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59414, RefRangeEnd = 59415, XrefRangeStart = 59414, XrefRangeEnd = 59414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Transfer(GizmoObjectVertexSnapSettings destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapSettings.NativeMethodInfoPtr_Transfer_Public_Void_GizmoObjectVertexSnapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000036C7 File Offset: 0x000018C7
		public GizmoObjectVertexSnapSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000306E4 File Offset: 0x0002E8E4
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x000036D0 File Offset: 0x000018D0
		public unsafe int _snapDestinationLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__snapDestinationLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__snapDestinationLayers)) = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0003070C File Offset: 0x0002E90C
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x000036EB File Offset: 0x000018EB
		public unsafe bool _canSnapToGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__canSnapToGrid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__canSnapToGrid)) = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00030734 File Offset: 0x0002E934
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00003706 File Offset: 0x00001906
		public unsafe bool _canSnapToObjectVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__canSnapToObjectVerts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapSettings.NativeFieldInfoPtr__canSnapToObjectVerts)) = value;
			}
		}

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr__snapDestinationLayers;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr__canSnapToGrid;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr__canSnapToObjectVerts;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_get_SnapDestinationLayers_Public_get_Int32_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_set_SnapDestinationLayers_Public_set_Void_Int32_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSnapToGrid_Public_get_Boolean_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_set_CanSnapToGrid_Public_set_Void_Boolean_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSnapToObjectVerts_Public_get_Boolean_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_set_CanSnapToObjectVerts_Public_set_Void_Boolean_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_IsLayerSnapDestination_Public_Boolean_Int32_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerSnapDestination_Public_Void_Int32_Boolean_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_Transfer_Public_Void_GizmoObjectVertexSnapSettings_0;
	}
}
