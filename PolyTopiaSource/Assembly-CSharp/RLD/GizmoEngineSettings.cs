using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x0200005D RID: 93
	[Serializable]
	public class GizmoEngineSettings : Settings
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00038830 File Offset: 0x00036A30
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoEngineSettings()
		{
			Il2CppClassPointerStore<GizmoEngineSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoEngineSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoEngineSettings>.NativeClassPtr);
			GizmoEngineSettings.NativeFieldInfoPtr__enableGizmoSorting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoEngineSettings>.NativeClassPtr, "_enableGizmoSorting");
			GizmoEngineSettings.NativeMethodInfoPtr_get_EnableGizmoSorting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEngineSettings>.NativeClassPtr, 100664172);
			GizmoEngineSettings.NativeMethodInfoPtr_set_EnableGizmoSorting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEngineSettings>.NativeClassPtr, 100664173);
			GizmoEngineSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEngineSettings>.NativeClassPtr, 100664174);
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000388B0 File Offset: 0x00036AB0
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x000388EC File Offset: 0x00036AEC
		public unsafe bool EnableGizmoSorting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEngineSettings.NativeMethodInfoPtr_get_EnableGizmoSorting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEngineSettings.NativeMethodInfoPtr_set_EnableGizmoSorting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0003892C File Offset: 0x00036B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60866, XrefRangeEnd = 60867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoEngineSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoEngineSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEngineSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000435F File Offset: 0x0000255F
		public GizmoEngineSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00038968 File Offset: 0x00036B68
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00004368 File Offset: 0x00002568
		public unsafe bool _enableGizmoSorting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoEngineSettings.NativeFieldInfoPtr__enableGizmoSorting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoEngineSettings.NativeFieldInfoPtr__enableGizmoSorting)) = value;
			}
		}

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr__enableGizmoSorting;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableGizmoSorting_Public_get_Boolean_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableGizmoSorting_Public_set_Void_Boolean_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
