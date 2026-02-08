using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200015A RID: 346
	public class MonoPInvokeCallbackAttribute : Attribute
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x00009537 File Offset: 0x00007737
		// Note: this type is marked as 'beforefieldinit'.
		static MonoPInvokeCallbackAttribute()
		{
			Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "MonoPInvokeCallbackAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr);
			MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr, 100667469);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00074BC4 File Offset: 0x00072DC4
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20605, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoPInvokeCallbackAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00009570 File Offset: 0x00007770
		public MonoPInvokeCallbackAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
