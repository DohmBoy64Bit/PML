using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003B RID: 59
	public static class WellKnownSymbols : Object
	{
		// Token: 0x06000791 RID: 1937 RVA: 0x00032B4C File Offset: 0x00030D4C
		// Note: this type is marked as 'beforefieldinit'.
		static WellKnownSymbols()
		{
			Il2CppClassPointerStore<WellKnownSymbols>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "WellKnownSymbols");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WellKnownSymbols>.NativeClassPtr);
			WellKnownSymbols.NativeFieldInfoPtr_VARARGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownSymbols>.NativeClassPtr, "VARARGS");
			WellKnownSymbols.NativeFieldInfoPtr_ENV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownSymbols>.NativeClassPtr, "ENV");
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00003E37 File Offset: 0x00002037
		public WellKnownSymbols(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00032BA4 File Offset: 0x00030DA4
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00003E40 File Offset: 0x00002040
		public unsafe static string VARARGS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WellKnownSymbols.NativeFieldInfoPtr_VARARGS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WellKnownSymbols.NativeFieldInfoPtr_VARARGS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00032BC4 File Offset: 0x00030DC4
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00003E52 File Offset: 0x00002052
		public unsafe static string ENV
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WellKnownSymbols.NativeFieldInfoPtr_ENV, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WellKnownSymbols.NativeFieldInfoPtr_ENV, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_VARARGS;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_ENV;
	}
}
