using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000119 RID: 281
	[Serializable]
	public class EditorToolbar : global::Il2CppSystem.Object
	{
		// Token: 0x06001AAD RID: 6829 RVA: 0x00088DF8 File Offset: 0x00086FF8
		// Note: this type is marked as 'beforefieldinit'.
		static EditorToolbar()
		{
			Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "EditorToolbar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr);
			EditorToolbar.NativeFieldInfoPtr__activeTabColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, "_activeTabColor");
			EditorToolbar.NativeFieldInfoPtr__numTabsPerRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, "_numTabsPerRow");
			EditorToolbar.NativeFieldInfoPtr__tabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, "_tabs");
			EditorToolbar.NativeFieldInfoPtr__activeTabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, "_activeTabIndex");
			EditorToolbar.NativeMethodInfoPtr_get_ActiveTabIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667272);
			EditorToolbar.NativeMethodInfoPtr_get_ActiveTab_Public_get_EditorToolbarTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667273);
			EditorToolbar.NativeMethodInfoPtr_get_ActiveTabColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667274);
			EditorToolbar.NativeMethodInfoPtr_set_ActiveTabColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667275);
			EditorToolbar.NativeMethodInfoPtr_get_NumTabsPerRow_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667276);
			EditorToolbar.NativeMethodInfoPtr_set_NumTabsPerRow_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667277);
			EditorToolbar.NativeMethodInfoPtr_get_NumTabs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667278);
			EditorToolbar.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EditorToolbarTab_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667279);
			EditorToolbar.NativeMethodInfoPtr_GetTabByIndex_Public_EditorToolbarTab_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr, 100667280);
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x00088F2C File Offset: 0x0008712C
		public unsafe int ActiveTabIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 21737, RefRangeEnd = 21743, XrefRangeStart = 21737, XrefRangeEnd = 21743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr_get_ActiveTabIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00088F68 File Offset: 0x00087168
		public unsafe EditorToolbarTab ActiveTab
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr_get_ActiveTab_Public_get_EditorToolbarTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EditorToolbarTab>(intPtr3) : null;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00088FA8 File Offset: 0x000871A8
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00088FE8 File Offset: 0x000871E8
		public unsafe Color ActiveTabColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr_get_ActiveTabColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr_set_ActiveTabColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0008902C File Offset: 0x0008722C
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x00089068 File Offset: 0x00087268
		public unsafe int NumTabsPerRow
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr_get_NumTabsPerRow_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr_set_NumTabsPerRow_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000890A8 File Offset: 0x000872A8
		public unsafe int NumTabs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr_get_NumTabs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000890E4 File Offset: 0x000872E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75919, RefRangeEnd = 75922, XrefRangeStart = 75917, XrefRangeEnd = 75919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorToolbar(Il2CppReferenceArray<EditorToolbarTab> tabs, int numTabsPerRow, Color activeTabColor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorToolbar>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tabs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numTabsPerRow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeTabColor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EditorToolbarTab_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00089150 File Offset: 0x00087350
		[CallerCount(0)]
		public unsafe EditorToolbarTab GetTabByIndex(int tabIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tabIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorToolbar.NativeMethodInfoPtr_GetTabByIndex_Public_EditorToolbarTab_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EditorToolbarTab>(intPtr3) : null;
			}
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0000BA1B File Offset: 0x00009C1B
		public EditorToolbar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0008919C File Offset: 0x0008739C
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0000BA24 File Offset: 0x00009C24
		public unsafe Color _activeTabColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbar.NativeFieldInfoPtr__activeTabColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbar.NativeFieldInfoPtr__activeTabColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x000891CC File Offset: 0x000873CC
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0000BA43 File Offset: 0x00009C43
		public unsafe int _numTabsPerRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbar.NativeFieldInfoPtr__numTabsPerRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbar.NativeFieldInfoPtr__numTabsPerRow)) = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x000891F4 File Offset: 0x000873F4
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0000BA5E File Offset: 0x00009C5E
		public unsafe Il2CppReferenceArray<EditorToolbarTab> _tabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbar.NativeFieldInfoPtr__tabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EditorToolbarTab>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbar.NativeFieldInfoPtr__tabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00089224 File Offset: 0x00087424
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000BA7D File Offset: 0x00009C7D
		public unsafe int _activeTabIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbar.NativeFieldInfoPtr__activeTabIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorToolbar.NativeFieldInfoPtr__activeTabIndex)) = value;
			}
		}

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeFieldInfoPtr__activeTabColor;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeFieldInfoPtr__numTabsPerRow;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeFieldInfoPtr__tabs;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeFieldInfoPtr__activeTabIndex;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveTabIndex_Public_get_Int32_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveTab_Public_get_EditorToolbarTab_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveTabColor_Public_get_Color_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveTabColor_Public_set_Void_Color_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTabsPerRow_Public_get_Int32_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_set_NumTabsPerRow_Public_set_Void_Int32_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTabs_Public_get_Int32_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EditorToolbarTab_Int32_Color_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_GetTabByIndex_Public_EditorToolbarTab_Int32_0;
	}
}
