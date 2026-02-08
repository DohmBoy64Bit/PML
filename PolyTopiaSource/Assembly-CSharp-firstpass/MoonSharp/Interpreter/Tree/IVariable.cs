using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005B RID: 91
	public class IVariable : Object
	{
		// Token: 0x0600094D RID: 2381 RVA: 0x000046F3 File Offset: 0x000028F3
		// Note: this type is marked as 'beforefieldinit'.
		static IVariable()
		{
			Il2CppClassPointerStore<IVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "IVariable");
			IVariable.NativeMethodInfoPtr_CompileAssignment_Public_Abstract_Virtual_New_Void_ByteCode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVariable>.NativeClassPtr, 100665047);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0003A2A4 File Offset: 0x000384A4
		[CallerCount(0)]
		public unsafe virtual void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackofs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tupleidx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVariable.NativeMethodInfoPtr_CompileAssignment_Public_Abstract_Virtual_New_Void_ByteCode_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00004722 File Offset: 0x00002922
		public IVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_CompileAssignment_Public_Abstract_Virtual_New_Void_ByteCode_Int32_Int32_0;
	}
}
