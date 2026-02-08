using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x0200006D RID: 109
	[Serializable]
	public class ObjectExtrudeGizmoHotkeys : Settings
	{
		// Token: 0x060007F8 RID: 2040 RVA: 0x0004028C File Offset: 0x0003E48C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectExtrudeGizmoHotkeys()
		{
			Il2CppClassPointerStore<ObjectExtrudeGizmoHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectExtrudeGizmoHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectExtrudeGizmoHotkeys>.NativeClassPtr);
			ObjectExtrudeGizmoHotkeys.NativeFieldInfoPtr__enableOverlapTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoHotkeys>.NativeClassPtr, "_enableOverlapTest");
			ObjectExtrudeGizmoHotkeys.NativeMethodInfoPtr_get_EnableOverlapTest_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoHotkeys>.NativeClassPtr, 100664498);
			ObjectExtrudeGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoHotkeys>.NativeClassPtr, 100664499);
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000402F8 File Offset: 0x0003E4F8
		public unsafe Hotkeys EnableOverlapTest
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoHotkeys.NativeMethodInfoPtr_get_EnableOverlapTest_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00040338 File Offset: 0x0003E538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62863, RefRangeEnd = 62864, XrefRangeStart = 62853, XrefRangeEnd = 62863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectExtrudeGizmoHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectExtrudeGizmoHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00004B07 File Offset: 0x00002D07
		public ObjectExtrudeGizmoHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00040374 File Offset: 0x0003E574
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00004B10 File Offset: 0x00002D10
		public unsafe Hotkeys _enableOverlapTest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoHotkeys.NativeFieldInfoPtr__enableOverlapTest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoHotkeys.NativeFieldInfoPtr__enableOverlapTest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr__enableOverlapTest;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableOverlapTest_Public_get_Hotkeys_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
