using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x0200021C RID: 540
	[Serializable]
	public class ObjectSelectionGizmosHotkeys : Settings
	{
		// Token: 0x06002A43 RID: 10819 RVA: 0x000C8A24 File Offset: 0x000C6C24
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionGizmosHotkeys()
		{
			Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionGizmosHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr);
			ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateMoveGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, "_activateMoveGizmo");
			ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateRotationGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, "_activateRotationGizmo");
			ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateScaleGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, "_activateScaleGizmo");
			ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateBoxScaleGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, "_activateBoxScaleGizmo");
			ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateUniversalGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, "_activateUniversalGizmo");
			ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateExtrudeGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, "_activateExtrudeGizmo");
			ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__toggleTransformSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, "_toggleTransformSpace");
			ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateMoveGizmo_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, 100669749);
			ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateRotationGizmo_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, 100669750);
			ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateScaleGizmo_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, 100669751);
			ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateBoxScaleGizmo_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, 100669752);
			ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateUniversalGizmo_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, 100669753);
			ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateExtrudeGizmo_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, 100669754);
			ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ToggleTransformSpace_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, 100669755);
			ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr, 100669756);
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000C8B80 File Offset: 0x000C6D80
		public unsafe Hotkeys ActivateMoveGizmo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateMoveGizmo_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x000C8BC0 File Offset: 0x000C6DC0
		public unsafe Hotkeys ActivateRotationGizmo
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateRotationGizmo_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000C8C00 File Offset: 0x000C6E00
		public unsafe Hotkeys ActivateScaleGizmo
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateScaleGizmo_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000C8C40 File Offset: 0x000C6E40
		public unsafe Hotkeys ActivateBoxScaleGizmo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateBoxScaleGizmo_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000C8C80 File Offset: 0x000C6E80
		public unsafe Hotkeys ActivateUniversalGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateUniversalGizmo_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000C8CC0 File Offset: 0x000C6EC0
		public unsafe Hotkeys ActivateExtrudeGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ActivateExtrudeGizmo_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x000C8D00 File Offset: 0x000C6F00
		public unsafe Hotkeys ToggleTransformSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr_get_ToggleTransformSpace_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000C8D40 File Offset: 0x000C6F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93504, RefRangeEnd = 93505, XrefRangeStart = 93452, XrefRangeEnd = 93504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionGizmosHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionGizmosHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00010A8A File Offset: 0x0000EC8A
		public ObjectSelectionGizmosHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000C8D7C File Offset: 0x000C6F7C
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x00010A93 File Offset: 0x0000EC93
		public unsafe Hotkeys _activateMoveGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateMoveGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateMoveGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000C8DAC File Offset: 0x000C6FAC
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x00010AB2 File Offset: 0x0000ECB2
		public unsafe Hotkeys _activateRotationGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateRotationGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateRotationGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000C8DDC File Offset: 0x000C6FDC
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x00010AD1 File Offset: 0x0000ECD1
		public unsafe Hotkeys _activateScaleGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateScaleGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateScaleGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000C8E0C File Offset: 0x000C700C
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		public unsafe Hotkeys _activateBoxScaleGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateBoxScaleGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateBoxScaleGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x000C8E3C File Offset: 0x000C703C
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x00010B0F File Offset: 0x0000ED0F
		public unsafe Hotkeys _activateUniversalGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateUniversalGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateUniversalGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000C8E6C File Offset: 0x000C706C
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x00010B2E File Offset: 0x0000ED2E
		public unsafe Hotkeys _activateExtrudeGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateExtrudeGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__activateExtrudeGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x000C8E9C File Offset: 0x000C709C
		// (set) Token: 0x06002A5A RID: 10842 RVA: 0x00010B4D File Offset: 0x0000ED4D
		public unsafe Hotkeys _toggleTransformSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__toggleTransformSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosHotkeys.NativeFieldInfoPtr__toggleTransformSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeFieldInfoPtr__activateMoveGizmo;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeFieldInfoPtr__activateRotationGizmo;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeFieldInfoPtr__activateScaleGizmo;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeFieldInfoPtr__activateBoxScaleGizmo;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeFieldInfoPtr__activateUniversalGizmo;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeFieldInfoPtr__activateExtrudeGizmo;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeFieldInfoPtr__toggleTransformSpace;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivateMoveGizmo_Public_get_Hotkeys_0;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivateRotationGizmo_Public_get_Hotkeys_0;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivateScaleGizmo_Public_get_Hotkeys_0;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivateBoxScaleGizmo_Public_get_Hotkeys_0;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivateUniversalGizmo_Public_get_Hotkeys_0;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivateExtrudeGizmo_Public_get_Hotkeys_0;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeMethodInfoPtr_get_ToggleTransformSpace_Public_get_Hotkeys_0;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
