using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.DataStructs;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E2 RID: 226
	public class LoopTracker : Object
	{
		// Token: 0x0600110B RID: 4363 RVA: 0x0005ACCC File Offset: 0x00058ECC
		// Note: this type is marked as 'beforefieldinit'.
		static LoopTracker()
		{
			Il2CppClassPointerStore<LoopTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "LoopTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopTracker>.NativeClassPtr);
			LoopTracker.NativeFieldInfoPtr_Loops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopTracker>.NativeClassPtr, "Loops");
			LoopTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopTracker>.NativeClassPtr, 100666336);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0005AD24 File Offset: 0x00058F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43061, XrefRangeEnd = 43069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoopTracker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00007155 File Offset: 0x00005355
		public LoopTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0005AD60 File Offset: 0x00058F60
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x0000715E File Offset: 0x0000535E
		public unsafe FastStack<ILoop> Loops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopTracker.NativeFieldInfoPtr_Loops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastStack<ILoop>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopTracker.NativeFieldInfoPtr_Loops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeFieldInfoPtr_Loops;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
