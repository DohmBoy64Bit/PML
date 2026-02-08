using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	public class Object2ObjectSnapHotkeys : Settings
	{
		// Token: 0x060022D0 RID: 8912 RVA: 0x000AB520 File Offset: 0x000A9720
		// Note: this type is marked as 'beforefieldinit'.
		static Object2ObjectSnapHotkeys()
		{
			Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Object2ObjectSnapHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr);
			Object2ObjectSnapHotkeys.NativeFieldInfoPtr__toggleSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, "_toggleSnap");
			Object2ObjectSnapHotkeys.NativeFieldInfoPtr__toggleSitBelowSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, "_toggleSitBelowSurface");
			Object2ObjectSnapHotkeys.NativeFieldInfoPtr__enableMoreControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, "_enableMoreControl");
			Object2ObjectSnapHotkeys.NativeFieldInfoPtr__enableFlexiSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, "_enableFlexiSnap");
			Object2ObjectSnapHotkeys.NativeMethodInfoPtr_get_ToggleSnap_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, 100668549);
			Object2ObjectSnapHotkeys.NativeMethodInfoPtr_get_ToggleSitBelowSurface_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, 100668550);
			Object2ObjectSnapHotkeys.NativeMethodInfoPtr_get_EnableMoreControl_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, 100668551);
			Object2ObjectSnapHotkeys.NativeMethodInfoPtr_get_EnableFlexiSnap_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, 100668552);
			Object2ObjectSnapHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr, 100668553);
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000AB604 File Offset: 0x000A9804
		public unsafe Hotkeys ToggleSnap
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapHotkeys.NativeMethodInfoPtr_get_ToggleSnap_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x000AB644 File Offset: 0x000A9844
		public unsafe Hotkeys ToggleSitBelowSurface
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapHotkeys.NativeMethodInfoPtr_get_ToggleSitBelowSurface_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000AB684 File Offset: 0x000A9884
		public unsafe Hotkeys EnableMoreControl
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapHotkeys.NativeMethodInfoPtr_get_EnableMoreControl_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x000AB6C4 File Offset: 0x000A98C4
		public unsafe Hotkeys EnableFlexiSnap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapHotkeys.NativeMethodInfoPtr_get_EnableFlexiSnap_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x000AB704 File Offset: 0x000A9904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87551, RefRangeEnd = 87552, XrefRangeStart = 87522, XrefRangeEnd = 87551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object2ObjectSnapHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnapHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0000E39F File Offset: 0x0000C59F
		public Object2ObjectSnapHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000AB740 File Offset: 0x000A9940
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		public unsafe Hotkeys _toggleSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapHotkeys.NativeFieldInfoPtr__toggleSnap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapHotkeys.NativeFieldInfoPtr__toggleSnap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x000AB770 File Offset: 0x000A9970
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x0000E3C7 File Offset: 0x0000C5C7
		public unsafe Hotkeys _toggleSitBelowSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapHotkeys.NativeFieldInfoPtr__toggleSitBelowSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapHotkeys.NativeFieldInfoPtr__toggleSitBelowSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x000AB7A0 File Offset: 0x000A99A0
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x0000E3E6 File Offset: 0x0000C5E6
		public unsafe Hotkeys _enableMoreControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapHotkeys.NativeFieldInfoPtr__enableMoreControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapHotkeys.NativeFieldInfoPtr__enableMoreControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000AB7D0 File Offset: 0x000A99D0
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x0000E405 File Offset: 0x0000C605
		public unsafe Hotkeys _enableFlexiSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapHotkeys.NativeFieldInfoPtr__enableFlexiSnap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapHotkeys.NativeFieldInfoPtr__enableFlexiSnap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeFieldInfoPtr__toggleSnap;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeFieldInfoPtr__toggleSitBelowSurface;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeFieldInfoPtr__enableMoreControl;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeFieldInfoPtr__enableFlexiSnap;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_get_ToggleSnap_Public_get_Hotkeys_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_get_ToggleSitBelowSurface_Public_get_Hotkeys_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableMoreControl_Public_get_Hotkeys_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableFlexiSnap_Public_get_Hotkeys_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
