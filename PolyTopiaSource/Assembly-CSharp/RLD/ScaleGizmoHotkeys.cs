using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000E7 RID: 231
	[Serializable]
	public class ScaleGizmoHotkeys : Settings
	{
		// Token: 0x06001464 RID: 5220 RVA: 0x0006EB18 File Offset: 0x0006CD18
		// Note: this type is marked as 'beforefieldinit'.
		static ScaleGizmoHotkeys()
		{
			Il2CppClassPointerStore<ScaleGizmoHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ScaleGizmoHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleGizmoHotkeys>.NativeClassPtr);
			ScaleGizmoHotkeys.NativeFieldInfoPtr__enableSnapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoHotkeys>.NativeClassPtr, "_enableSnapping");
			ScaleGizmoHotkeys.NativeFieldInfoPtr__changeMultiAxisMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoHotkeys>.NativeClassPtr, "_changeMultiAxisMode");
			ScaleGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoHotkeys>.NativeClassPtr, 100666171);
			ScaleGizmoHotkeys.NativeMethodInfoPtr_get_ChangeMultiAxisMode_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoHotkeys>.NativeClassPtr, 100666172);
			ScaleGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoHotkeys>.NativeClassPtr, 100666173);
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0006EBAC File Offset: 0x0006CDAC
		public unsafe Hotkeys EnableSnapping
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoHotkeys.NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0006EBEC File Offset: 0x0006CDEC
		public unsafe Hotkeys ChangeMultiAxisMode
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoHotkeys.NativeMethodInfoPtr_get_ChangeMultiAxisMode_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0006EC2C File Offset: 0x0006CE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71885, RefRangeEnd = 71886, XrefRangeStart = 71868, XrefRangeEnd = 71885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaleGizmoHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleGizmoHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00009BC1 File Offset: 0x00007DC1
		public ScaleGizmoHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0006EC68 File Offset: 0x0006CE68
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x00009BCA File Offset: 0x00007DCA
		public unsafe Hotkeys _enableSnapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoHotkeys.NativeFieldInfoPtr__enableSnapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoHotkeys.NativeFieldInfoPtr__enableSnapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0006EC98 File Offset: 0x0006CE98
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x00009BE9 File Offset: 0x00007DE9
		public unsafe Hotkeys _changeMultiAxisMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoHotkeys.NativeFieldInfoPtr__changeMultiAxisMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoHotkeys.NativeFieldInfoPtr__changeMultiAxisMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr__enableSnapping;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr__changeMultiAxisMode;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSnapping_Public_get_Hotkeys_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_get_ChangeMultiAxisMode_Public_get_Hotkeys_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
