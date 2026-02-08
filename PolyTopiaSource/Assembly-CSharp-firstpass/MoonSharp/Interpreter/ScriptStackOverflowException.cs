using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000042 RID: 66
	public class ScriptStackOverflowException : ScriptRuntimeException
	{
		// Token: 0x0600080F RID: 2063 RVA: 0x00003F93 File Offset: 0x00002193
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptStackOverflowException()
		{
			Il2CppClassPointerStore<ScriptStackOverflowException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ScriptStackOverflowException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptStackOverflowException>.NativeClassPtr);
			ScriptStackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptStackOverflowException>.NativeClassPtr, 100664845);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0003517C File Offset: 0x0003337C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25662, XrefRangeEnd = 25668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptStackOverflowException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptStackOverflowException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptStackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00003FCC File Offset: 0x000021CC
		public ScriptStackOverflowException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
