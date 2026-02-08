using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020001CF RID: 463
	[Serializable]
	public class ObjectGridSnapHotkeys : Settings
	{
		// Token: 0x060023EA RID: 9194 RVA: 0x000AF098 File Offset: 0x000AD298
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectGridSnapHotkeys()
		{
			Il2CppClassPointerStore<ObjectGridSnapHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectGridSnapHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectGridSnapHotkeys>.NativeClassPtr);
			ObjectGridSnapHotkeys.NativeFieldInfoPtr__beginGridSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapHotkeys>.NativeClassPtr, "_beginGridSnap");
			ObjectGridSnapHotkeys.NativeMethodInfoPtr_get_BeginGridSnap_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapHotkeys>.NativeClassPtr, 100668680);
			ObjectGridSnapHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapHotkeys>.NativeClassPtr, 100668681);
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x000AF104 File Offset: 0x000AD304
		public unsafe Hotkeys BeginGridSnap
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapHotkeys.NativeMethodInfoPtr_get_BeginGridSnap_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x000AF144 File Offset: 0x000AD344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88490, RefRangeEnd = 88491, XrefRangeStart = 88480, XrefRangeEnd = 88490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectGridSnapHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectGridSnapHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0000EB95 File Offset: 0x0000CD95
		public ObjectGridSnapHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000AF180 File Offset: 0x000AD380
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x0000EB9E File Offset: 0x0000CD9E
		public unsafe Hotkeys _beginGridSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapHotkeys.NativeFieldInfoPtr__beginGridSnap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapHotkeys.NativeFieldInfoPtr__beginGridSnap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeFieldInfoPtr__beginGridSnap;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_get_BeginGridSnap_Public_get_Hotkeys_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
