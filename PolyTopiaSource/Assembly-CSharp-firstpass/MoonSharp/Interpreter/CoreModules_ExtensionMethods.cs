using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004F RID: 79
	public static class CoreModules_ExtensionMethods : Object
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x00004291 File Offset: 0x00002491
		// Note: this type is marked as 'beforefieldinit'.
		static CoreModules_ExtensionMethods()
		{
			Il2CppClassPointerStore<CoreModules_ExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "CoreModules_ExtensionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreModules_ExtensionMethods>.NativeClassPtr);
			CoreModules_ExtensionMethods.NativeMethodInfoPtr_Has_Public_Static_Boolean_CoreModules_CoreModules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreModules_ExtensionMethods>.NativeClassPtr, 100664926);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000371CC File Offset: 0x000353CC
		[CallerCount(0)]
		public unsafe static bool Has(this CoreModules val, CoreModules flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreModules_ExtensionMethods.NativeMethodInfoPtr_Has_Public_Static_Boolean_CoreModules_CoreModules_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000042CA File Offset: 0x000024CA
		public CoreModules_ExtensionMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Static_Boolean_CoreModules_CoreModules_0;
	}
}
