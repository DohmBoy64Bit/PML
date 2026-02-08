using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class ObjectSelectionHotkeys : Settings
	{
		// Token: 0x06002A5B RID: 10843 RVA: 0x000C8ECC File Offset: 0x000C70CC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionHotkeys()
		{
			Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr);
			ObjectSelectionHotkeys.NativeFieldInfoPtr__appendToSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, "_appendToSelection");
			ObjectSelectionHotkeys.NativeFieldInfoPtr__multiDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, "_multiDeselect");
			ObjectSelectionHotkeys.NativeFieldInfoPtr__deleteSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, "_deleteSelected");
			ObjectSelectionHotkeys.NativeFieldInfoPtr__focusCameraOnSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, "_focusCameraOnSelection");
			ObjectSelectionHotkeys.NativeFieldInfoPtr__duplicateSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, "_duplicateSelection");
			ObjectSelectionHotkeys.NativeMethodInfoPtr_get_AppendToSelection_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, 100669757);
			ObjectSelectionHotkeys.NativeMethodInfoPtr_get_MultiDeselect_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, 100669758);
			ObjectSelectionHotkeys.NativeMethodInfoPtr_get_DeleteSelected_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, 100669759);
			ObjectSelectionHotkeys.NativeMethodInfoPtr_get_FocusCameraOnSelection_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, 100669760);
			ObjectSelectionHotkeys.NativeMethodInfoPtr_get_DuplicateSelection_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, 100669761);
			ObjectSelectionHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr, 100669762);
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x000C8FD8 File Offset: 0x000C71D8
		public unsafe Hotkeys AppendToSelection
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionHotkeys.NativeMethodInfoPtr_get_AppendToSelection_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x000C9018 File Offset: 0x000C7218
		public unsafe Hotkeys MultiDeselect
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionHotkeys.NativeMethodInfoPtr_get_MultiDeselect_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000C9058 File Offset: 0x000C7258
		public unsafe Hotkeys DeleteSelected
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionHotkeys.NativeMethodInfoPtr_get_DeleteSelected_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x000C9098 File Offset: 0x000C7298
		public unsafe Hotkeys FocusCameraOnSelection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionHotkeys.NativeMethodInfoPtr_get_FocusCameraOnSelection_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000C90D8 File Offset: 0x000C72D8
		public unsafe Hotkeys DuplicateSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionHotkeys.NativeMethodInfoPtr_get_DuplicateSelection_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000C9118 File Offset: 0x000C7318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93541, RefRangeEnd = 93542, XrefRangeStart = 93505, XrefRangeEnd = 93541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00010B6C File Offset: 0x0000ED6C
		public ObjectSelectionHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x000C9154 File Offset: 0x000C7354
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x00010B75 File Offset: 0x0000ED75
		public unsafe Hotkeys _appendToSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__appendToSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__appendToSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000C9184 File Offset: 0x000C7384
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x00010B94 File Offset: 0x0000ED94
		public unsafe Hotkeys _multiDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__multiDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__multiDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000C91B4 File Offset: 0x000C73B4
		// (set) Token: 0x06002A68 RID: 10856 RVA: 0x00010BB3 File Offset: 0x0000EDB3
		public unsafe Hotkeys _deleteSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__deleteSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__deleteSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x000C91E4 File Offset: 0x000C73E4
		// (set) Token: 0x06002A6A RID: 10858 RVA: 0x00010BD2 File Offset: 0x0000EDD2
		public unsafe Hotkeys _focusCameraOnSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__focusCameraOnSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__focusCameraOnSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x000C9214 File Offset: 0x000C7414
		// (set) Token: 0x06002A6C RID: 10860 RVA: 0x00010BF1 File Offset: 0x0000EDF1
		public unsafe Hotkeys _duplicateSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__duplicateSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionHotkeys.NativeFieldInfoPtr__duplicateSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeFieldInfoPtr__appendToSelection;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeFieldInfoPtr__multiDeselect;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeFieldInfoPtr__deleteSelected;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeFieldInfoPtr__focusCameraOnSelection;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeFieldInfoPtr__duplicateSelection;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeMethodInfoPtr_get_AppendToSelection_Public_get_Hotkeys_0;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeMethodInfoPtr_get_MultiDeselect_Public_get_Hotkeys_0;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteSelected_Public_get_Hotkeys_0;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusCameraOnSelection_Public_get_Hotkeys_0;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeMethodInfoPtr_get_DuplicateSelection_Public_get_Hotkeys_0;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
