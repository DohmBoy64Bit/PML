using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000079 RID: 121
	public class SceneGizmoCamPrjSwitchLabel : Object
	{
		// Token: 0x060008ED RID: 2285 RVA: 0x00043E80 File Offset: 0x00042080
		// Note: this type is marked as 'beforefieldinit'.
		static SceneGizmoCamPrjSwitchLabel()
		{
			Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneGizmoCamPrjSwitchLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr);
			SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__sceneGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, "_sceneGizmo");
			SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, "_handle");
			SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__labelQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, "_labelQuad");
			SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_get_Handle_Public_get_GizmoHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, 100664644);
			SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, 100664645);
			SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, 100664646);
			SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, 100664647);
			SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, 100664648);
			SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_UpdateTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, 100664649);
			SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr, 100664650);
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00043F78 File Offset: 0x00042178
		public unsafe GizmoHandle Handle
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_get_Handle_Public_get_GizmoHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00043FB8 File Offset: 0x000421B8
		public unsafe int Id
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 57996, RefRangeEnd = 58044, XrefRangeStart = 57996, XrefRangeEnd = 58044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00043FF4 File Offset: 0x000421F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63989, XrefRangeEnd = 64014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGizmoCamPrjSwitchLabel(SceneGizmo sceneGizmo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmoCamPrjSwitchLabel>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneGizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00044040 File Offset: 0x00042240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64077, RefRangeEnd = 64078, XrefRangeStart = 64014, XrefRangeEnd = 64077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00044074 File Offset: 0x00042274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64078, XrefRangeEnd = 64080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000440B8 File Offset: 0x000422B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64105, RefRangeEnd = 64106, XrefRangeStart = 64080, XrefRangeEnd = 64105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_UpdateTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000440EC File Offset: 0x000422EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64106, XrefRangeEnd = 64113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoHandlePicked(Gizmo gizmo, int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamPrjSwitchLabel.NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0000507C File Offset: 0x0000327C
		public SceneGizmoCamPrjSwitchLabel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0004413C File Offset: 0x0004233C
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00005085 File Offset: 0x00003285
		public unsafe SceneGizmo _sceneGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__sceneGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__sceneGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0004416C File Offset: 0x0004236C
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x000050A4 File Offset: 0x000032A4
		public unsafe GizmoHandle _handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0004419C File Offset: 0x0004239C
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x000050C3 File Offset: 0x000032C3
		public unsafe QuadShape2D _labelQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__labelQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCamPrjSwitchLabel.NativeFieldInfoPtr__labelQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr__sceneGizmo;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr__labelQuad;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_GizmoHandle_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Private_Void_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0;
	}
}
