using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Compatibility.Frameworks;

namespace MoonSharp.Interpreter.Compatibility
{
	// Token: 0x02000122 RID: 290
	public static class Framework : Object
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x0006EFDC File Offset: 0x0006D1DC
		// Note: this type is marked as 'beforefieldinit'.
		static Framework()
		{
			Il2CppClassPointerStore<Framework>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Compatibility", "Framework");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Framework>.NativeClassPtr);
			Framework.NativeFieldInfoPtr_s_FrameworkCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Framework>.NativeClassPtr, "s_FrameworkCurrent");
			Framework.NativeMethodInfoPtr_get_Do_Public_Static_get_FrameworkBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Framework>.NativeClassPtr, 100667113);
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x0006F034 File Offset: 0x0006D234
		public unsafe static FrameworkBase Do
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51665, XrefRangeEnd = 51669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Framework.NativeMethodInfoPtr_get_Do_Public_Static_get_FrameworkBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FrameworkBase>(intPtr3) : null;
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0000845C File Offset: 0x0000665C
		public Framework(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x0006F068 File Offset: 0x0006D268
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x00008465 File Offset: 0x00006665
		public unsafe static FrameworkCurrent s_FrameworkCurrent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Framework.NativeFieldInfoPtr_s_FrameworkCurrent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FrameworkCurrent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Framework.NativeFieldInfoPtr_s_FrameworkCurrent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeFieldInfoPtr_s_FrameworkCurrent;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_get_Do_Public_Static_get_FrameworkBase_0;
	}
}
