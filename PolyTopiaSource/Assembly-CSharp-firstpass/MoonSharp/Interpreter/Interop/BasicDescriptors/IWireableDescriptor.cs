using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000DB RID: 219
	public class IWireableDescriptor : Object
	{
		// Token: 0x060010E2 RID: 4322 RVA: 0x0000702B File Offset: 0x0000522B
		// Note: this type is marked as 'beforefieldinit'.
		static IWireableDescriptor()
		{
			Il2CppClassPointerStore<IWireableDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.BasicDescriptors", "IWireableDescriptor");
			IWireableDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Abstract_Virtual_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWireableDescriptor>.NativeClassPtr, 100666310);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0005A334 File Offset: 0x00058534
		[CallerCount(0)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWireableDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Abstract_Virtual_New_Void_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0000705A File Offset: 0x0000525A
		public IWireableDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Abstract_Virtual_New_Void_Table_0;
	}
}
