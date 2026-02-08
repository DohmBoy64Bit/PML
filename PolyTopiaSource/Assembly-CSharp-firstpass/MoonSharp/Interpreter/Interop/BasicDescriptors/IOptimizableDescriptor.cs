using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D7 RID: 215
	public class IOptimizableDescriptor : Object
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x00006EF9 File Offset: 0x000050F9
		// Note: this type is marked as 'beforefieldinit'.
		static IOptimizableDescriptor()
		{
			Il2CppClassPointerStore<IOptimizableDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.BasicDescriptors", "IOptimizableDescriptor");
			IOptimizableDescriptor.NativeMethodInfoPtr_Optimize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptimizableDescriptor>.NativeClassPtr, 100666281);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00059610 File Offset: 0x00057810
		[CallerCount(0)]
		public unsafe virtual void Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptimizableDescriptor.NativeMethodInfoPtr_Optimize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00006F28 File Offset: 0x00005128
		public IOptimizableDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Public_Abstract_Virtual_New_Void_0;
	}
}
