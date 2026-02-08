using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class MoveGizmoHotkeys : Settings
	{
		// Token: 0x060011D4 RID: 4564 RVA: 0x00063914 File Offset: 0x00061B14
		// Note: this type is marked as 'beforefieldinit'.
		static MoveGizmoHotkeys()
		{
			Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MoveGizmoHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr);
			MoveGizmoHotkeys.NativeFieldInfoPtr__enable2DMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr, "_enable2DMode");
			MoveGizmoHotkeys.NativeFieldInfoPtr__enableSnapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr, "_enableSnapping");
			MoveGizmoHotkeys.NativeFieldInfoPtr__enableVertexSnapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr, "_enableVertexSnapping");
			MoveGizmoHotkeys.NativeMethodInfoPtr_get_Enable2DMode_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr, 100665710);
			MoveGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr, 100665711);
			MoveGizmoHotkeys.NativeMethodInfoPtr_get_EnableVertexSnapping_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr, 100665712);
			MoveGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr, 100665713);
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000639D0 File Offset: 0x00061BD0
		public unsafe Hotkeys Enable2DMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoHotkeys.NativeMethodInfoPtr_get_Enable2DMode_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00063A10 File Offset: 0x00061C10
		public unsafe Hotkeys EnableSnapping
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00063A50 File Offset: 0x00061C50
		public unsafe Hotkeys EnableVertexSnapping
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoHotkeys.NativeMethodInfoPtr_get_EnableVertexSnapping_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00063A90 File Offset: 0x00061C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70030, RefRangeEnd = 70031, XrefRangeStart = 70006, XrefRangeEnd = 70030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveGizmoHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveGizmoHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00009090 File Offset: 0x00007290
		public MoveGizmoHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00063ACC File Offset: 0x00061CCC
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x00009099 File Offset: 0x00007299
		public unsafe Hotkeys _enable2DMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoHotkeys.NativeFieldInfoPtr__enable2DMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoHotkeys.NativeFieldInfoPtr__enable2DMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00063AFC File Offset: 0x00061CFC
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x000090B8 File Offset: 0x000072B8
		public unsafe Hotkeys _enableSnapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoHotkeys.NativeFieldInfoPtr__enableSnapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoHotkeys.NativeFieldInfoPtr__enableSnapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00063B2C File Offset: 0x00061D2C
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x000090D7 File Offset: 0x000072D7
		public unsafe Hotkeys _enableVertexSnapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoHotkeys.NativeFieldInfoPtr__enableVertexSnapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoHotkeys.NativeFieldInfoPtr__enableVertexSnapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeFieldInfoPtr__enable2DMode;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeFieldInfoPtr__enableSnapping;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeFieldInfoPtr__enableVertexSnapping;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_get_Enable2DMode_Public_get_Hotkeys_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableVertexSnapping_Public_get_Hotkeys_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
