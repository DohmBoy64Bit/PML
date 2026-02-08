using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E1 RID: 225
	public class ILoop : Object
	{
		// Token: 0x06001107 RID: 4359 RVA: 0x0005ABE4 File Offset: 0x00058DE4
		// Note: this type is marked as 'beforefieldinit'.
		static ILoop()
		{
			Il2CppClassPointerStore<ILoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "ILoop");
			ILoop.NativeMethodInfoPtr_CompileBreak_Public_Abstract_Virtual_New_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoop>.NativeClassPtr, 100666334);
			ILoop.NativeMethodInfoPtr_IsBoundary_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoop>.NativeClassPtr, 100666335);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0005AC34 File Offset: 0x00058E34
		[CallerCount(0)]
		public unsafe virtual void CompileBreak(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILoop.NativeMethodInfoPtr_CompileBreak_Public_Abstract_Virtual_New_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0005AC84 File Offset: 0x00058E84
		[CallerCount(0)]
		public unsafe virtual bool IsBoundary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILoop.NativeMethodInfoPtr_IsBoundary_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0000714C File Offset: 0x0000534C
		public ILoop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_CompileBreak_Public_Abstract_Virtual_New_Void_ByteCode_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_IsBoundary_Public_Abstract_Virtual_New_Boolean_0;
	}
}
