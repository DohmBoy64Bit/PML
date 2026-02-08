using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A1 RID: 161
	public class AnonWrapper : Object
	{
		// Token: 0x06000CCC RID: 3276 RVA: 0x00005C2C File Offset: 0x00003E2C
		// Note: this type is marked as 'beforefieldinit'.
		static AnonWrapper()
		{
			Il2CppClassPointerStore<AnonWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "AnonWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnonWrapper>.NativeClassPtr);
			AnonWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnonWrapper>.NativeClassPtr, 100665525);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00048198 File Offset: 0x00046398
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnonWrapper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnonWrapper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnonWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00005C65 File Offset: 0x00003E65
		public AnonWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
