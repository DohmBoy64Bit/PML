using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000249 RID: 585
	public class PropertyGridSelector : MonoBehaviour
	{
		// Token: 0x06002D9F RID: 11679 RVA: 0x000D46F0 File Offset: 0x000D28F0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridSelector()
		{
			Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr);
			PropertyGridSelector.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, "highlight");
			PropertyGridSelector.NativeFieldInfoPtr_propertyGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, "propertyGrid");
			PropertyGridSelector.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, "selected");
			PropertyGridSelector.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, "color");
			PropertyGridSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, 100670187);
			PropertyGridSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, 100670183);
			PropertyGridSelector.NativeMethodInfoPtr_IsCursorOverUi_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, 100670184);
			PropertyGridSelector.NativeMethodInfoPtr_Select_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, 100670185);
			PropertyGridSelector.NativeMethodInfoPtr_ClearSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr, 100670186);
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000D47D4 File Offset: 0x000D29D4
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000D4810 File Offset: 0x000D2A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98019, XrefRangeEnd = 98048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000D4844 File Offset: 0x000D2A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98048, XrefRangeEnd = 98066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCursorOverUi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridSelector.NativeMethodInfoPtr_IsCursorOverUi_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000D4880 File Offset: 0x000D2A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98066, XrefRangeEnd = 98089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridSelector.NativeMethodInfoPtr_Select_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000D48C4 File Offset: 0x000D2AC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98106, RefRangeEnd = 98108, XrefRangeStart = 98089, XrefRangeEnd = 98106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridSelector.NativeMethodInfoPtr_ClearSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000122B4 File Offset: 0x000104B4
		public PropertyGridSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x000D48F8 File Offset: 0x000D2AF8
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x000122BD File Offset: 0x000104BD
		public unsafe static Color highlight
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(PropertyGridSelector.NativeFieldInfoPtr_highlight, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyGridSelector.NativeFieldInfoPtr_highlight, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x000D4914 File Offset: 0x000D2B14
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x000122CF File Offset: 0x000104CF
		public unsafe GameObject propertyGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridSelector.NativeFieldInfoPtr_propertyGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridSelector.NativeFieldInfoPtr_propertyGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000D4944 File Offset: 0x000D2B44
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x000122EE File Offset: 0x000104EE
		public unsafe GameObject selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridSelector.NativeFieldInfoPtr_selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridSelector.NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000D4974 File Offset: 0x000D2B74
		// (set) Token: 0x06002DAD RID: 11693 RVA: 0x0001230D File Offset: 0x0001050D
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridSelector.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridSelector.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeFieldInfoPtr_propertyGrid;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_IsCursorOverUi_Private_Boolean_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_Select_Private_Void_GameObject_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Private_Void_0;
	}
}
