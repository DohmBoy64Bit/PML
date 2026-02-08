using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A6 RID: 166
	public class IPropertyTableAssigner : Object
	{
		// Token: 0x06000D08 RID: 3336 RVA: 0x00005DA3 File Offset: 0x00003FA3
		// Note: this type is marked as 'beforefieldinit'.
		static IPropertyTableAssigner()
		{
			Il2CppClassPointerStore<IPropertyTableAssigner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "IPropertyTableAssigner");
			IPropertyTableAssigner.NativeMethodInfoPtr_AssignObjectUnchecked_Public_Abstract_Virtual_New_Void_Object_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyTableAssigner>.NativeClassPtr, 100665555);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0004929C File Offset: 0x0004749C
		[CallerCount(0)]
		public unsafe virtual void AssignObjectUnchecked(Object o, Table data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyTableAssigner.NativeMethodInfoPtr_AssignObjectUnchecked_Public_Abstract_Virtual_New_Void_Object_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00005DD2 File Offset: 0x00003FD2
		public IPropertyTableAssigner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_AssignObjectUnchecked_Public_Abstract_Virtual_New_Void_Object_Table_0;
	}
}
