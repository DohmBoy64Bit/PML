using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000E3 RID: 227
	[Serializable]
	public class RotationGizmoHotkeys : Settings
	{
		// Token: 0x06001399 RID: 5017 RVA: 0x0006B848 File Offset: 0x00069A48
		// Note: this type is marked as 'beforefieldinit'.
		static RotationGizmoHotkeys()
		{
			Il2CppClassPointerStore<RotationGizmoHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RotationGizmoHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotationGizmoHotkeys>.NativeClassPtr);
			RotationGizmoHotkeys.NativeFieldInfoPtr__enableSnapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoHotkeys>.NativeClassPtr, "_enableSnapping");
			RotationGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoHotkeys>.NativeClassPtr, 100666048);
			RotationGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoHotkeys>.NativeClassPtr, 100666049);
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0006B8B4 File Offset: 0x00069AB4
		public unsafe Hotkeys EnableSnapping
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0006B8F4 File Offset: 0x00069AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71395, RefRangeEnd = 71397, XrefRangeStart = 71385, XrefRangeEnd = 71395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotationGizmoHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotationGizmoHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0000975D File Offset: 0x0000795D
		public RotationGizmoHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x0006B930 File Offset: 0x00069B30
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x00009766 File Offset: 0x00007966
		public unsafe Hotkeys _enableSnapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoHotkeys.NativeFieldInfoPtr__enableSnapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoHotkeys.NativeFieldInfoPtr__enableSnapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeFieldInfoPtr__enableSnapping;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
