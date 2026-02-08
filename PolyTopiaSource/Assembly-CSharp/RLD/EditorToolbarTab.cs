using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x0200011A RID: 282
	[Serializable]
	public class EditorToolbarTab : Object
	{
		// Token: 0x06001AC0 RID: 6848 RVA: 0x0008924C File Offset: 0x0008744C
		// Note: this type is marked as 'beforefieldinit'.
		static EditorToolbarTab()
		{
			Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "EditorToolbarTab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr);
			EditorToolbarTab.NativeFieldInfoPtr__tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, "_tooltip");
			EditorToolbarTab.NativeFieldInfoPtr__text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, "_text");
			EditorToolbarTab.NativeFieldInfoPtr__targetToolbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, "_targetToolbar");
			EditorToolbarTab.NativeFieldInfoPtr__targetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, "_targetSettings");
			EditorToolbarTab.NativeMethodInfoPtr_get_Tooltip_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667282);
			EditorToolbarTab.NativeMethodInfoPtr_set_Tooltip_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667283);
			EditorToolbarTab.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667284);
			EditorToolbarTab.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667285);
			EditorToolbarTab.NativeMethodInfoPtr_get_TargetToolbar_Public_get_EditorToolbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667286);
			EditorToolbarTab.NativeMethodInfoPtr_set_TargetToolbar_Public_set_Void_EditorToolbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667287);
			EditorToolbarTab.NativeMethodInfoPtr_get_NumTargetSettings_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667288);
			EditorToolbarTab.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667281);
			EditorToolbarTab.NativeMethodInfoPtr_AddTargetSettings_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr, 100667289);
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x00089380 File Offset: 0x00087580
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x000893B8 File Offset: 0x000875B8
		public unsafe string Tooltip
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr_get_Tooltip_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75922, XrefRangeEnd = 75923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr_set_Tooltip_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x000893FC File Offset: 0x000875FC
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x00089434 File Offset: 0x00087634
		public unsafe string Text
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75923, XrefRangeEnd = 75924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00089478 File Offset: 0x00087678
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x000894B8 File Offset: 0x000876B8
		public unsafe EditorToolbar TargetToolbar
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr_get_TargetToolbar_Public_get_EditorToolbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EditorToolbar>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75924, XrefRangeEnd = 75925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr_set_TargetToolbar_Public_set_Void_EditorToolbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000894FC File Offset: 0x000876FC
		public unsafe int NumTargetSettings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75925, XrefRangeEnd = 75926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr_get_NumTargetSettings_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00089538 File Offset: 0x00087738
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 75943, RefRangeEnd = 75957, XrefRangeStart = 75926, XrefRangeEnd = 75943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorToolbarTab(string text, string tooltip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorToolbarTab>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00089598 File Offset: 0x00087798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75957, XrefRangeEnd = 75963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTargetSettings(Settings targetSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetSettings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbarTab.NativeMethodInfoPtr_AddTargetSettings_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0000BA98 File Offset: 0x00009C98
		public EditorToolbarTab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x000895DC File Offset: 0x000877DC
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0000BAA1 File Offset: 0x00009CA1
		public unsafe string _tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbarTab.NativeFieldInfoPtr__tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbarTab.NativeFieldInfoPtr__tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00089604 File Offset: 0x00087804
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		public unsafe string _text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbarTab.NativeFieldInfoPtr__text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbarTab.NativeFieldInfoPtr__text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0008962C File Offset: 0x0008782C
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0000BADF File Offset: 0x00009CDF
		public unsafe EditorToolbar _targetToolbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbarTab.NativeFieldInfoPtr__targetToolbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorToolbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbarTab.NativeFieldInfoPtr__targetToolbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0008965C File Offset: 0x0008785C
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0000BAFE File Offset: 0x00009CFE
		public unsafe List<Settings> _targetSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbarTab.NativeFieldInfoPtr__targetSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Settings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbarTab.NativeFieldInfoPtr__targetSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr__tooltip;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr__text;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr__targetToolbar;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr__targetSettings;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_get_Tooltip_Public_get_String_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_set_Tooltip_Public_set_Void_String_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetToolbar_Public_get_EditorToolbar_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetToolbar_Public_set_Void_EditorToolbar_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTargetSettings_Public_get_Int32_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetSettings_Public_Void_Settings_0;
	}
}
