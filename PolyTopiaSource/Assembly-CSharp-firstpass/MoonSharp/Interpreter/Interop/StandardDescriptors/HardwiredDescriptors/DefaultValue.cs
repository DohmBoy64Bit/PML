using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
	// Token: 0x020000C1 RID: 193
	public sealed class DefaultValue : Object
	{
		// Token: 0x06000F12 RID: 3858 RVA: 0x00052370 File Offset: 0x00050570
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultValue()
		{
			Il2CppClassPointerStore<DefaultValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors", "DefaultValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultValue>.NativeClassPtr);
			DefaultValue.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultValue>.NativeClassPtr, "Instance");
			DefaultValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValue>.NativeClassPtr, 100666012);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000523C8 File Offset: 0x000505C8
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00006927 File Offset: 0x00004B27
		public DefaultValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00052404 File Offset: 0x00050604
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00006930 File Offset: 0x00004B30
		public unsafe static DefaultValue Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultValue.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultValue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultValue.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
