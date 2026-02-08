using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E0 RID: 224
	public class IClosureBuilder : Object
	{
		// Token: 0x06001104 RID: 4356 RVA: 0x00007114 File Offset: 0x00005314
		// Note: this type is marked as 'beforefieldinit'.
		static IClosureBuilder()
		{
			Il2CppClassPointerStore<IClosureBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "IClosureBuilder");
			IClosureBuilder.NativeMethodInfoPtr_CreateUpvalue_Public_Abstract_Virtual_New_SymbolRef_BuildTimeScope_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClosureBuilder>.NativeClassPtr, 100666333);
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0005AB74 File Offset: 0x00058D74
		[CallerCount(0)]
		public unsafe virtual SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClosureBuilder.NativeMethodInfoPtr_CreateUpvalue_Public_Abstract_Virtual_New_SymbolRef_BuildTimeScope_SymbolRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00007143 File Offset: 0x00005343
		public IClosureBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_CreateUpvalue_Public_Abstract_Virtual_New_SymbolRef_BuildTimeScope_SymbolRef_0;
	}
}
