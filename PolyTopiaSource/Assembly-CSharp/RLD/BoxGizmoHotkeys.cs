using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x02000081 RID: 129
	[Serializable]
	public class BoxGizmoHotkeys : Settings
	{
		// Token: 0x060009D2 RID: 2514 RVA: 0x00047590 File Offset: 0x00045790
		// Note: this type is marked as 'beforefieldinit'.
		static BoxGizmoHotkeys()
		{
			Il2CppClassPointerStore<BoxGizmoHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxGizmoHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxGizmoHotkeys>.NativeClassPtr);
			BoxGizmoHotkeys.NativeFieldInfoPtr__enableSnapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmoHotkeys>.NativeClassPtr, "_enableSnapping");
			BoxGizmoHotkeys.NativeFieldInfoPtr__enableCenterPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmoHotkeys>.NativeClassPtr, "_enableCenterPivot");
			BoxGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoHotkeys>.NativeClassPtr, 100664770);
			BoxGizmoHotkeys.NativeMethodInfoPtr_get_EnableCenterPivot_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoHotkeys>.NativeClassPtr, 100664771);
			BoxGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoHotkeys>.NativeClassPtr, 100664772);
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00047624 File Offset: 0x00045824
		public unsafe Hotkeys EnableSnapping
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00047664 File Offset: 0x00045864
		public unsafe Hotkeys EnableCenterPivot
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoHotkeys.NativeMethodInfoPtr_get_EnableCenterPivot_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000476A4 File Offset: 0x000458A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64964, RefRangeEnd = 64967, XrefRangeStart = 64947, XrefRangeEnd = 64964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxGizmoHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoxGizmoHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00005613 File Offset: 0x00003813
		public BoxGizmoHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000476E0 File Offset: 0x000458E0
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x0000561C File Offset: 0x0000381C
		public unsafe Hotkeys _enableSnapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoHotkeys.NativeFieldInfoPtr__enableSnapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoHotkeys.NativeFieldInfoPtr__enableSnapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00047710 File Offset: 0x00045910
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x0000563B File Offset: 0x0000383B
		public unsafe Hotkeys _enableCenterPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoHotkeys.NativeFieldInfoPtr__enableCenterPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoHotkeys.NativeFieldInfoPtr__enableCenterPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr__enableSnapping;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr__enableCenterPivot;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableCenterPivot_Public_get_Hotkeys_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
