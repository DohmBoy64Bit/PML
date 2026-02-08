using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020001AE RID: 430
	[Serializable]
	public class SceneGridHotkeys : Settings
	{
		// Token: 0x06002167 RID: 8551 RVA: 0x000A6280 File Offset: 0x000A4480
		// Note: this type is marked as 'beforefieldinit'.
		static SceneGridHotkeys()
		{
			Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneGridHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr);
			SceneGridHotkeys.NativeFieldInfoPtr__gridUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr, "_gridUp");
			SceneGridHotkeys.NativeFieldInfoPtr__gridDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr, "_gridDown");
			SceneGridHotkeys.NativeFieldInfoPtr__snapToCursorPickPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr, "_snapToCursorPickPoint");
			SceneGridHotkeys.NativeMethodInfoPtr_get_GridUp_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr, 100668377);
			SceneGridHotkeys.NativeMethodInfoPtr_get_GridDown_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr, 100668378);
			SceneGridHotkeys.NativeMethodInfoPtr_get_SnapToCursorPickPoint_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr, 100668379);
			SceneGridHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr, 100668380);
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x000A633C File Offset: 0x000A453C
		public unsafe Hotkeys GridUp
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGridHotkeys.NativeMethodInfoPtr_get_GridUp_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x000A637C File Offset: 0x000A457C
		public unsafe Hotkeys GridDown
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGridHotkeys.NativeMethodInfoPtr_get_GridDown_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000A63BC File Offset: 0x000A45BC
		public unsafe Hotkeys SnapToCursorPickPoint
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGridHotkeys.NativeMethodInfoPtr_get_SnapToCursorPickPoint_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x000A63FC File Offset: 0x000A45FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86200, XrefRangeEnd = 86223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGridHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGridHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGridHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x0000D984 File Offset: 0x0000BB84
		public SceneGridHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000A6438 File Offset: 0x000A4638
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x0000D98D File Offset: 0x0000BB8D
		public unsafe Hotkeys _gridUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGridHotkeys.NativeFieldInfoPtr__gridUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGridHotkeys.NativeFieldInfoPtr__gridUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x000A6468 File Offset: 0x000A4668
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x0000D9AC File Offset: 0x0000BBAC
		public unsafe Hotkeys _gridDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGridHotkeys.NativeFieldInfoPtr__gridDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGridHotkeys.NativeFieldInfoPtr__gridDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x000A6498 File Offset: 0x000A4698
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x0000D9CB File Offset: 0x0000BBCB
		public unsafe Hotkeys _snapToCursorPickPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGridHotkeys.NativeFieldInfoPtr__snapToCursorPickPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGridHotkeys.NativeFieldInfoPtr__snapToCursorPickPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeFieldInfoPtr__gridUp;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeFieldInfoPtr__gridDown;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeFieldInfoPtr__snapToCursorPickPoint;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_get_GridUp_Public_get_Hotkeys_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_get_GridDown_Public_get_Hotkeys_0;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr_get_SnapToCursorPickPoint_Public_get_Hotkeys_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
