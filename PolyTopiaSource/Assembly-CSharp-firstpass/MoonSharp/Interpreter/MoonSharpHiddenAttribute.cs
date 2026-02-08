using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000046 RID: 70
	public sealed class MoonSharpHiddenAttribute : Attribute
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x0000415F File Offset: 0x0000235F
		// Note: this type is marked as 'beforefieldinit'.
		static MoonSharpHiddenAttribute()
		{
			Il2CppClassPointerStore<MoonSharpHiddenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "MoonSharpHiddenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonSharpHiddenAttribute>.NativeClassPtr);
			MoonSharpHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpHiddenAttribute>.NativeClassPtr, 100664887);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0003656C File Offset: 0x0003476C
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20605, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpHiddenAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpHiddenAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00004198 File Offset: 0x00002398
		public MoonSharpHiddenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
