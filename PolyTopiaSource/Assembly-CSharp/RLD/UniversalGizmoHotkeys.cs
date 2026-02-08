using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public class UniversalGizmoHotkeys : Settings
	{
		// Token: 0x060015A6 RID: 5542 RVA: 0x00073DD8 File Offset: 0x00071FD8
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalGizmoHotkeys()
		{
			Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UniversalGizmoHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr);
			UniversalGizmoHotkeys.NativeFieldInfoPtr__enable2DMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr, "_enable2DMode");
			UniversalGizmoHotkeys.NativeFieldInfoPtr__enableSnapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr, "_enableSnapping");
			UniversalGizmoHotkeys.NativeFieldInfoPtr__enableVertexSnapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr, "_enableVertexSnapping");
			UniversalGizmoHotkeys.NativeMethodInfoPtr_get_Enable2DMode_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr, 100666367);
			UniversalGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr, 100666368);
			UniversalGizmoHotkeys.NativeMethodInfoPtr_get_EnableVertexSnapping_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr, 100666369);
			UniversalGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr, 100666370);
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00073E94 File Offset: 0x00072094
		public unsafe Hotkeys Enable2DMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoHotkeys.NativeMethodInfoPtr_get_Enable2DMode_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00073ED4 File Offset: 0x000720D4
		public unsafe Hotkeys EnableSnapping
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00073F14 File Offset: 0x00072114
		public unsafe Hotkeys EnableVertexSnapping
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoHotkeys.NativeMethodInfoPtr_get_EnableVertexSnapping_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00073F54 File Offset: 0x00072154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72741, RefRangeEnd = 72742, XrefRangeStart = 72717, XrefRangeEnd = 72741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalGizmoHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGizmoHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0000A2EE File Offset: 0x000084EE
		public UniversalGizmoHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00073F90 File Offset: 0x00072190
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x0000A2F7 File Offset: 0x000084F7
		public unsafe Hotkeys _enable2DMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoHotkeys.NativeFieldInfoPtr__enable2DMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoHotkeys.NativeFieldInfoPtr__enable2DMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00073FC0 File Offset: 0x000721C0
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x0000A316 File Offset: 0x00008516
		public unsafe Hotkeys _enableSnapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoHotkeys.NativeFieldInfoPtr__enableSnapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoHotkeys.NativeFieldInfoPtr__enableSnapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00073FF0 File Offset: 0x000721F0
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x0000A335 File Offset: 0x00008535
		public unsafe Hotkeys _enableVertexSnapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoHotkeys.NativeFieldInfoPtr__enableVertexSnapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoHotkeys.NativeFieldInfoPtr__enableVertexSnapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr__enable2DMode;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr__enableSnapping;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeFieldInfoPtr__enableVertexSnapping;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_get_Enable2DMode_Public_get_Hotkeys_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableVertexSnapping_Public_get_Hotkeys_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
